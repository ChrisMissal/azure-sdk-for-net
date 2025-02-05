// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class IndexingParametersConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ParsingMode))
            {
                writer.WritePropertyName("parsingMode");
                writer.WriteStringValue(ParsingMode.Value.ToString());
            }
            if (Optional.IsDefined(ExcludedFileNameExtensions))
            {
                writer.WritePropertyName("excludedFileNameExtensions");
                writer.WriteStringValue(ExcludedFileNameExtensions);
            }
            if (Optional.IsDefined(IndexedFileNameExtensions))
            {
                writer.WritePropertyName("indexedFileNameExtensions");
                writer.WriteStringValue(IndexedFileNameExtensions);
            }
            if (Optional.IsDefined(FailOnUnsupportedContentType))
            {
                writer.WritePropertyName("failOnUnsupportedContentType");
                writer.WriteBooleanValue(FailOnUnsupportedContentType.Value);
            }
            if (Optional.IsDefined(FailOnUnprocessableDocument))
            {
                writer.WritePropertyName("failOnUnprocessableDocument");
                writer.WriteBooleanValue(FailOnUnprocessableDocument.Value);
            }
            if (Optional.IsDefined(IndexStorageMetadataOnlyForOversizedDocuments))
            {
                writer.WritePropertyName("indexStorageMetadataOnlyForOversizedDocuments");
                writer.WriteBooleanValue(IndexStorageMetadataOnlyForOversizedDocuments.Value);
            }
            if (Optional.IsDefined(DelimitedTextHeaders))
            {
                writer.WritePropertyName("delimitedTextHeaders");
                writer.WriteStringValue(DelimitedTextHeaders);
            }
            if (Optional.IsDefined(DelimitedTextDelimiter))
            {
                writer.WritePropertyName("delimitedTextDelimiter");
                writer.WriteStringValue(DelimitedTextDelimiter);
            }
            if (Optional.IsDefined(FirstLineContainsHeaders))
            {
                writer.WritePropertyName("firstLineContainsHeaders");
                writer.WriteBooleanValue(FirstLineContainsHeaders.Value);
            }
            if (Optional.IsDefined(DocumentRoot))
            {
                writer.WritePropertyName("documentRoot");
                writer.WriteStringValue(DocumentRoot);
            }
            if (Optional.IsDefined(DataToExtract))
            {
                writer.WritePropertyName("dataToExtract");
                writer.WriteStringValue(DataToExtract.Value.ToString());
            }
            if (Optional.IsDefined(ImageAction))
            {
                writer.WritePropertyName("imageAction");
                writer.WriteStringValue(ImageAction.Value.ToString());
            }
            if (Optional.IsDefined(AllowSkillsetToReadFileData))
            {
                writer.WritePropertyName("allowSkillsetToReadFileData");
                writer.WriteBooleanValue(AllowSkillsetToReadFileData.Value);
            }
            if (Optional.IsDefined(PdfTextRotationAlgorithm))
            {
                writer.WritePropertyName("pdfTextRotationAlgorithm");
                writer.WriteStringValue(PdfTextRotationAlgorithm.Value.ToString());
            }
            if (Optional.IsDefined(ExecutionEnvironment))
            {
                writer.WritePropertyName("executionEnvironment");
                writer.WriteStringValue(ExecutionEnvironment.Value.ToString());
            }
            if (Optional.IsDefined(_queryTimeout))
            {
                writer.WritePropertyName("queryTimeout");
                writer.WriteStringValue(_queryTimeout);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IndexingParametersConfiguration DeserializeIndexingParametersConfiguration(JsonElement element)
        {
            Optional<BlobIndexerParsingMode> parsingMode = default;
            Optional<string> excludedFileNameExtensions = default;
            Optional<string> indexedFileNameExtensions = default;
            Optional<bool> failOnUnsupportedContentType = default;
            Optional<bool> failOnUnprocessableDocument = default;
            Optional<bool> indexStorageMetadataOnlyForOversizedDocuments = default;
            Optional<string> delimitedTextHeaders = default;
            Optional<string> delimitedTextDelimiter = default;
            Optional<bool> firstLineContainsHeaders = default;
            Optional<string> documentRoot = default;
            Optional<BlobIndexerDataToExtract> dataToExtract = default;
            Optional<BlobIndexerImageAction> imageAction = default;
            Optional<bool> allowSkillsetToReadFileData = default;
            Optional<BlobIndexerPdfTextRotationAlgorithm> pdfTextRotationAlgorithm = default;
            Optional<IndexerExecutionEnvironment> executionEnvironment = default;
            Optional<string> queryTimeout = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parsingMode"))
                {
                    parsingMode = new BlobIndexerParsingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("excludedFileNameExtensions"))
                {
                    excludedFileNameExtensions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexedFileNameExtensions"))
                {
                    indexedFileNameExtensions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failOnUnsupportedContentType"))
                {
                    failOnUnsupportedContentType = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("failOnUnprocessableDocument"))
                {
                    failOnUnprocessableDocument = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("indexStorageMetadataOnlyForOversizedDocuments"))
                {
                    indexStorageMetadataOnlyForOversizedDocuments = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("delimitedTextHeaders"))
                {
                    delimitedTextHeaders = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delimitedTextDelimiter"))
                {
                    delimitedTextDelimiter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstLineContainsHeaders"))
                {
                    firstLineContainsHeaders = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("documentRoot"))
                {
                    documentRoot = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataToExtract"))
                {
                    dataToExtract = new BlobIndexerDataToExtract(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("imageAction"))
                {
                    imageAction = new BlobIndexerImageAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowSkillsetToReadFileData"))
                {
                    allowSkillsetToReadFileData = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pdfTextRotationAlgorithm"))
                {
                    pdfTextRotationAlgorithm = new BlobIndexerPdfTextRotationAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("executionEnvironment"))
                {
                    executionEnvironment = new IndexerExecutionEnvironment(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queryTimeout"))
                {
                    queryTimeout = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IndexingParametersConfiguration(Optional.ToNullable(parsingMode), excludedFileNameExtensions.Value, indexedFileNameExtensions.Value, Optional.ToNullable(failOnUnsupportedContentType), Optional.ToNullable(failOnUnprocessableDocument), Optional.ToNullable(indexStorageMetadataOnlyForOversizedDocuments), delimitedTextHeaders.Value, delimitedTextDelimiter.Value, Optional.ToNullable(firstLineContainsHeaders), documentRoot.Value, Optional.ToNullable(dataToExtract), Optional.ToNullable(imageAction), Optional.ToNullable(allowSkillsetToReadFileData), Optional.ToNullable(pdfTextRotationAlgorithm), Optional.ToNullable(executionEnvironment), queryTimeout.Value, additionalProperties);
        }
    }
}
